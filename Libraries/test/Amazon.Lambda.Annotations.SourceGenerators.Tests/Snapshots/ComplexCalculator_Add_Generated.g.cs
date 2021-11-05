﻿using System;
using System.Linq;
using System.Collections.Generic;
using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;

namespace TestServerlessApp
{
    public class ComplexCalculator_Add_Generated
    {
        private readonly ComplexCalculator complexCalculator;

        public ComplexCalculator_Add_Generated()
        {
            complexCalculator = new ComplexCalculator();
        }

        public Amazon.Lambda.APIGatewayEvents.APIGatewayHttpApiV2ProxyResponse Add(Amazon.Lambda.APIGatewayEvents.APIGatewayHttpApiV2ProxyRequest request, Amazon.Lambda.Core.ILambdaContext context)
        {
            var complexNumbers = request.Body;

            var response = complexCalculator.Add(complexNumbers, context, request);

            var body = System.Text.Json.JsonSerializer.Serialize(response);

            return new APIGatewayHttpApiV2ProxyResponse
            {
                Body = body,
                Headers = new Dictionary<string, string>
                {
                    {"Content-Type", "application/json"}
                },
                StatusCode = 200
            };
        }
    }
}