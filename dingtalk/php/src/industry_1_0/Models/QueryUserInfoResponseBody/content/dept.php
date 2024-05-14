<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserInfoResponseBody\content;

use AlibabaCloud\Tea\Model;

class dept extends Model
{
    /**
     * @example 2021-06-02 17:44:17
     *
     * @var string
     */
    public $gmtCreateStr;

    /**
     * @example 2021-06-02 17:44:17
     *
     * @var string
     */
    public $gmtModifiedStr;

    /**
     * @description This parameter is required.
     *
     * @example 123
     *
     * @var int
     */
    public $id;

    /**
     * @description This parameter is required.
     *
     * @example 科室名称2
     *
     * @var string
     */
    public $name;

    /**
     * @var int
     */
    public $relId;
    protected $_name = [
        'gmtCreateStr'   => 'gmtCreateStr',
        'gmtModifiedStr' => 'gmtModifiedStr',
        'id'             => 'id',
        'name'           => 'name',
        'relId'          => 'relId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->gmtCreateStr) {
            $res['gmtCreateStr'] = $this->gmtCreateStr;
        }
        if (null !== $this->gmtModifiedStr) {
            $res['gmtModifiedStr'] = $this->gmtModifiedStr;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->relId) {
            $res['relId'] = $this->relId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return dept
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['gmtCreateStr'])) {
            $model->gmtCreateStr = $map['gmtCreateStr'];
        }
        if (isset($map['gmtModifiedStr'])) {
            $model->gmtModifiedStr = $map['gmtModifiedStr'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['relId'])) {
            $model->relId = $map['relId'];
        }

        return $model;
    }
}
