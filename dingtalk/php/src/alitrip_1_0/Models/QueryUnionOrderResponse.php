<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryUnionOrderResponse extends Model
{
    /**
     * @var string[]
     */
    public $headers;

    /**
     * @var QueryUnionOrderResponseBody
     */
    public $body;
    protected $_name = [
        'headers' => 'headers',
        'body'    => 'body',
    ];

    public function validate()
    {
        Model::validateRequired('headers', $this->headers, true);
        Model::validateRequired('body', $this->body, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->headers) {
            $res['headers'] = $this->headers;
        }
        if (null !== $this->body) {
            $res['body'] = null !== $this->body ? $this->body->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryUnionOrderResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['headers'])) {
            $model->headers = $map['headers'];
        }
        if (isset($map['body'])) {
            $model->body = QueryUnionOrderResponseBody::fromMap($map['body']);
        }

        return $model;
    }
}
