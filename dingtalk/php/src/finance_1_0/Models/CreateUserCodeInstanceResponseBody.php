<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateUserCodeInstanceResponseBody extends Model
{
    /**
     * @var string
     */
    public $codeDetailUrl;

    /**
     * @description This parameter is required.
     *
     * @example codexxxxxx
     *
     * @var string
     */
    public $codeId;
    protected $_name = [
        'codeDetailUrl' => 'codeDetailUrl',
        'codeId'        => 'codeId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->codeDetailUrl) {
            $res['codeDetailUrl'] = $this->codeDetailUrl;
        }
        if (null !== $this->codeId) {
            $res['codeId'] = $this->codeId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateUserCodeInstanceResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['codeDetailUrl'])) {
            $model->codeDetailUrl = $map['codeDetailUrl'];
        }
        if (isset($map['codeId'])) {
            $model->codeId = $map['codeId'];
        }

        return $model;
    }
}
