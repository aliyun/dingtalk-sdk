<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models;

use AlibabaCloud\Tea\Model;

class HrbrainImportCustomRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var mixed[][]
     */
    public $body;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $corpId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $modelCode;
    protected $_name = [
        'body' => 'body',
        'corpId' => 'corpId',
        'modelCode' => 'modelCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->body) {
            $res['body'] = $this->body;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->modelCode) {
            $res['modelCode'] = $this->modelCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return HrbrainImportCustomRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['body'])) {
            if (!empty($map['body'])) {
                $model->body = $map['body'];
            }
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['modelCode'])) {
            $model->modelCode = $map['modelCode'];
        }

        return $model;
    }
}
