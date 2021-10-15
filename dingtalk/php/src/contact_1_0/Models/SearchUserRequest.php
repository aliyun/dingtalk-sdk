<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class SearchUserRequest extends Model
{
    /**
     * @var int
     */
    public $dingOrgId;

    /**
     * @description 用户名称、名称拼音或英文名称
     *
     * @var string
     */
    public $queryWord;

    /**
     * @description 分页查询锚点
     *
     * @var int
     */
    public $offset;

    /**
     * @description 分页长度
     *
     * @var int
     */
    public $size;

    /**
     * @description 精确匹配的字段。1：匹配用户名称。不填则为模糊匹配
     *
     * @var int
     */
    public $fullMatchField;
    protected $_name = [
        'dingOrgId'      => 'dingOrgId',
        'queryWord'      => 'queryWord',
        'offset'         => 'offset',
        'size'           => 'size',
        'fullMatchField' => 'fullMatchField',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->queryWord) {
            $res['queryWord'] = $this->queryWord;
        }
        if (null !== $this->offset) {
            $res['offset'] = $this->offset;
        }
        if (null !== $this->size) {
            $res['size'] = $this->size;
        }
        if (null !== $this->fullMatchField) {
            $res['fullMatchField'] = $this->fullMatchField;
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
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['queryWord'])) {
            $model->queryWord = $map['queryWord'];
        }
        if (isset($map['offset'])) {
            $model->offset = $map['offset'];
        }
        if (isset($map['size'])) {
            $model->size = $map['size'];
        }
        if (isset($map['fullMatchField'])) {
            $model->fullMatchField = $map['fullMatchField'];
        }

        return $model;
    }
}
