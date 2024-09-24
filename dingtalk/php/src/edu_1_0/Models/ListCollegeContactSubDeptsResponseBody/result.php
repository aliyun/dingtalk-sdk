<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ListCollegeContactSubDeptsResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var bool
     */
    public $autoAddUser;

    /**
     * @var bool
     */
    public $createDeptGroup;

    /**
     * @example dept456
     *
     * @var string
     */
    public $deptCode;

    /**
     * @example 456
     *
     * @var int
     */
    public $deptId;

    /**
     * @example contact_class_dept
     *
     * @var string
     */
    public $deptType;

    /**
     * @example {}
     *
     * @var string
     */
    public $extension;

    /**
     * @var bool
     */
    public $fromUnionOrg;

    /**
     * @example 软件工程
     *
     * @var string
     */
    public $name;

    /**
     * @example 200
     *
     * @var int
     */
    public $parentId;

    /**
     * @example 软件工程标识
     *
     * @var string
     */
    public $sourceIdentifier;

    /**
     * @example 200
     *
     * @var int
     */
    public $struId;

    /**
     * @example campus
     *
     * @var string
     */
    public $tags;
    protected $_name = [
        'autoAddUser'      => 'autoAddUser',
        'createDeptGroup'  => 'createDeptGroup',
        'deptCode'         => 'deptCode',
        'deptId'           => 'deptId',
        'deptType'         => 'deptType',
        'extension'        => 'extension',
        'fromUnionOrg'     => 'fromUnionOrg',
        'name'             => 'name',
        'parentId'         => 'parentId',
        'sourceIdentifier' => 'sourceIdentifier',
        'struId'           => 'struId',
        'tags'             => 'tags',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->autoAddUser) {
            $res['autoAddUser'] = $this->autoAddUser;
        }
        if (null !== $this->createDeptGroup) {
            $res['createDeptGroup'] = $this->createDeptGroup;
        }
        if (null !== $this->deptCode) {
            $res['deptCode'] = $this->deptCode;
        }
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->deptType) {
            $res['deptType'] = $this->deptType;
        }
        if (null !== $this->extension) {
            $res['extension'] = $this->extension;
        }
        if (null !== $this->fromUnionOrg) {
            $res['fromUnionOrg'] = $this->fromUnionOrg;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->parentId) {
            $res['parentId'] = $this->parentId;
        }
        if (null !== $this->sourceIdentifier) {
            $res['sourceIdentifier'] = $this->sourceIdentifier;
        }
        if (null !== $this->struId) {
            $res['struId'] = $this->struId;
        }
        if (null !== $this->tags) {
            $res['tags'] = $this->tags;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['autoAddUser'])) {
            $model->autoAddUser = $map['autoAddUser'];
        }
        if (isset($map['createDeptGroup'])) {
            $model->createDeptGroup = $map['createDeptGroup'];
        }
        if (isset($map['deptCode'])) {
            $model->deptCode = $map['deptCode'];
        }
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['deptType'])) {
            $model->deptType = $map['deptType'];
        }
        if (isset($map['extension'])) {
            $model->extension = $map['extension'];
        }
        if (isset($map['fromUnionOrg'])) {
            $model->fromUnionOrg = $map['fromUnionOrg'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['parentId'])) {
            $model->parentId = $map['parentId'];
        }
        if (isset($map['sourceIdentifier'])) {
            $model->sourceIdentifier = $map['sourceIdentifier'];
        }
        if (isset($map['struId'])) {
            $model->struId = $map['struId'];
        }
        if (isset($map['tags'])) {
            $model->tags = $map['tags'];
        }

        return $model;
    }
}
