<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class SearchUserRequest extends Model
{
    /**
     * @description 精确匹配的字段。1：匹配用户名称。不填则为模糊匹配
     *
     * @var int
     */
    public $fullMatchField;

    /**
     * @description 分页查询锚点
     *
     * @var int
     */
    public $offset;

    /**
     * @description 用户名称、名称拼音或英文名称
     *
     * @var string
     */
    public $queryWord;

    /**
     * @description 分页长度
     *
     * @var int
     */
    public $size;
    protected $_name = [
        'fullMatchField' => 'fullMatchField',
        'offset'         => 'offset',
        'queryWord'      => 'queryWord',
        'size'           => 'size',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fullMatchField) {
            $res['fullMatchField'] = $this->fullMatchField;
        }
        if (null !== $this->offset) {
            $res['offset'] = $this->offset;
        }
        if (null !== $this->queryWord) {
            $res['queryWord'] = $this->queryWord;
        }
        if (null !== $this->size) {
            $res['size'] = $this->size;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SearchUserRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fullMatchField'])) {
            $model->fullMatchField = $map['fullMatchField'];
        }
        if (isset($map['offset'])) {
            $model->offset = $map['offset'];
        }
        if (isset($map['queryWord'])) {
            $model->queryWord = $map['queryWord'];
        }
        if (isset($map['size'])) {
            $model->size = $map['size'];
        }

        return $model;
    }
}
