<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models;

use AlibabaCloud\Tea\Model;

class RenameDentryRequest extends Model
{
    /**
     * @description 名称, 规则：
     * 1. 头尾不能包含空格，否则会自动去除
     * 2. 不能包含特殊字符，包括：制表符、*、"、<、>、|
     * 3. 不能以"."结尾
     * @var string
     */
    public $newName;

    /**
     * @description 用户id
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'newName' => 'newName',
        'unionId' => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->newName) {
            $res['newName'] = $this->newName;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RenameDentryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['newName'])) {
            $model->newName = $map['newName'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
