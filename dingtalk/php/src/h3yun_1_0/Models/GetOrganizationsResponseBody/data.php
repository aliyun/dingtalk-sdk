<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\GetOrganizationsResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @example G06935
     *
     * @var string
     */
    public $code;

    /**
     * @example null
     *
     * @var string
     */
    public $description;

    /**
     * @example 2b1a79e9-7545-437f-94ad-b6ab5561733f
     *
     * @var string
     */
    public $id;

    /**
     * @example 行政部
     *
     * @var string
     */
    public $name;

    /**
     * @example 18f923a7-5a5e-426d-94ae-a55ad1a4b240
     *
     * @var string
     */
    public $parentId;

    /**
     * @example 1
     *
     * @var int
     */
    public $sortKey;

    /**
     * @example OrganizationUnit
     *
     * @var string
     */
    public $unitType;
    protected $_name = [
        'code' => 'code',
        'description' => 'description',
        'id' => 'id',
        'name' => 'name',
        'parentId' => 'parentId',
        'sortKey' => 'sortKey',
        'unitType' => 'unitType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->parentId) {
            $res['parentId'] = $this->parentId;
        }
        if (null !== $this->sortKey) {
            $res['sortKey'] = $this->sortKey;
        }
        if (null !== $this->unitType) {
            $res['unitType'] = $this->unitType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['parentId'])) {
            $model->parentId = $map['parentId'];
        }
        if (isset($map['sortKey'])) {
            $model->sortKey = $map['sortKey'];
        }
        if (isset($map['unitType'])) {
            $model->unitType = $map['unitType'];
        }

        return $model;
    }
}
