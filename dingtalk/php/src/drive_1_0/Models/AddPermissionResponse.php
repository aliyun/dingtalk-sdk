<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddPermissionResponse extends Model
{
    /**
     * @var string[]
     */
    public $headers;

    /**
     * @var int
     */
    public $statusCode;
    protected $_name = [
        'headers'    => 'headers',
        'statusCode' => 'statusCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->headers) {
            $res['headers'] = $this->headers;
        }
        if (null !== $this->statusCode) {
            $res['statusCode'] = $this->statusCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddPermissionResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['headers'])) {
            $model->headers = $map['headers'];
        }
        if (isset($map['statusCode'])) {
            $model->statusCode = $map['statusCode'];
        }

        return $model;
    }
}
