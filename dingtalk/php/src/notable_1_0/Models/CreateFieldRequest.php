<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateFieldRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $name;

    /**
     * @example key: id或者name
     * value: 对应字段值,不同类型的字段传入的value值不同
     * - text: "TextString"          // 文本字符串
     * - number: 123                 // 整数/浮点数均可
     * - singleSelect: "optionIdxxx1" | "optionName1" // 单选选项Id/单选选项名
     * - date: 1688601600000 ｜ "2023-12-20 03:00"
     * // 支持传时间戳或ISO 8601字符串
     * - user: [{
     * uid: \"1234567\"            // 用户uid
     * }, {
     * uid: \"2345678\"
     * }]
     *
     * @var mixed[]
     */
    public $property;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $type;

    /**
     * @description This parameter is required.
     *
     * @example union_id
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'name' => 'name',
        'property' => 'property',
        'type' => 'type',
        'operatorId' => 'operatorId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->property) {
            $res['property'] = $this->property;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateFieldRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['property'])) {
            $model->property = $map['property'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
