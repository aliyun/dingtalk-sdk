<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateCollegeContactDeptRequest\hideSceneConfig;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateCollegeContactDeptRequest\outerSceneConfig;
use AlibabaCloud\Tea\Model;

class CreateCollegeContactDeptRequest extends Model
{
    /**
     * @var bool
     */
    public $autoApproveApply;

    /**
     * @example 这是组织单元简介
     *
     * @var string
     */
    public $brief;

    /**
     * @example 20000
     *
     * @var string
     */
    public $code;

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
     * @var int[]
     */
    public $deptPermits;

    /**
     * @description This parameter is required.
     *
     * @example contact_class_dept
     *
     * @var string
     */
    public $deptType;

    /**
     * @var bool
     */
    public $empApplyJoinDept;

    /**
     * @var string[]
     */
    public $extension;

    /**
     * @var bool
     */
    public $hideDept;

    /**
     * @var hideSceneConfig
     */
    public $hideSceneConfig;

    /**
     * @description This parameter is required.
     *
     * @example 软件工程
     *
     * @var string
     */
    public $name;

    /**
     * @example 20
     *
     * @var int
     */
    public $order;

    /**
     * @var bool
     */
    public $outerDept;

    /**
     * @var bool
     */
    public $outerDeptOnlySelf;

    /**
     * @var int[]
     */
    public $outerPermitDepts;

    /**
     * @var string[]
     */
    public $outerPermitUsers;

    /**
     * @var outerSceneConfig
     */
    public $outerSceneConfig;

    /**
     * @description This parameter is required.
     *
     * @example 20
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
     * @description This parameter is required.
     *
     * @example 10
     *
     * @var int
     */
    public $struId;

    /**
     * @example 138xxxx0000
     *
     * @var string
     */
    public $telephone;

    /**
     * @var string[]
     */
    public $userPermits;
    protected $_name = [
        'autoApproveApply'  => 'autoApproveApply',
        'brief'             => 'brief',
        'code'              => 'code',
        'createDeptGroup'   => 'createDeptGroup',
        'deptCode'          => 'deptCode',
        'deptPermits'       => 'deptPermits',
        'deptType'          => 'deptType',
        'empApplyJoinDept'  => 'empApplyJoinDept',
        'extension'         => 'extension',
        'hideDept'          => 'hideDept',
        'hideSceneConfig'   => 'hideSceneConfig',
        'name'              => 'name',
        'order'             => 'order',
        'outerDept'         => 'outerDept',
        'outerDeptOnlySelf' => 'outerDeptOnlySelf',
        'outerPermitDepts'  => 'outerPermitDepts',
        'outerPermitUsers'  => 'outerPermitUsers',
        'outerSceneConfig'  => 'outerSceneConfig',
        'parentId'          => 'parentId',
        'sourceIdentifier'  => 'sourceIdentifier',
        'struId'            => 'struId',
        'telephone'         => 'telephone',
        'userPermits'       => 'userPermits',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->autoApproveApply) {
            $res['autoApproveApply'] = $this->autoApproveApply;
        }
        if (null !== $this->brief) {
            $res['brief'] = $this->brief;
        }
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->createDeptGroup) {
            $res['createDeptGroup'] = $this->createDeptGroup;
        }
        if (null !== $this->deptCode) {
            $res['deptCode'] = $this->deptCode;
        }
        if (null !== $this->deptPermits) {
            $res['deptPermits'] = $this->deptPermits;
        }
        if (null !== $this->deptType) {
            $res['deptType'] = $this->deptType;
        }
        if (null !== $this->empApplyJoinDept) {
            $res['empApplyJoinDept'] = $this->empApplyJoinDept;
        }
        if (null !== $this->extension) {
            $res['extension'] = $this->extension;
        }
        if (null !== $this->hideDept) {
            $res['hideDept'] = $this->hideDept;
        }
        if (null !== $this->hideSceneConfig) {
            $res['hideSceneConfig'] = null !== $this->hideSceneConfig ? $this->hideSceneConfig->toMap() : null;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->order) {
            $res['order'] = $this->order;
        }
        if (null !== $this->outerDept) {
            $res['outerDept'] = $this->outerDept;
        }
        if (null !== $this->outerDeptOnlySelf) {
            $res['outerDeptOnlySelf'] = $this->outerDeptOnlySelf;
        }
        if (null !== $this->outerPermitDepts) {
            $res['outerPermitDepts'] = $this->outerPermitDepts;
        }
        if (null !== $this->outerPermitUsers) {
            $res['outerPermitUsers'] = $this->outerPermitUsers;
        }
        if (null !== $this->outerSceneConfig) {
            $res['outerSceneConfig'] = null !== $this->outerSceneConfig ? $this->outerSceneConfig->toMap() : null;
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
        if (null !== $this->telephone) {
            $res['telephone'] = $this->telephone;
        }
        if (null !== $this->userPermits) {
            $res['userPermits'] = $this->userPermits;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateCollegeContactDeptRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['autoApproveApply'])) {
            $model->autoApproveApply = $map['autoApproveApply'];
        }
        if (isset($map['brief'])) {
            $model->brief = $map['brief'];
        }
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['createDeptGroup'])) {
            $model->createDeptGroup = $map['createDeptGroup'];
        }
        if (isset($map['deptCode'])) {
            $model->deptCode = $map['deptCode'];
        }
        if (isset($map['deptPermits'])) {
            if (!empty($map['deptPermits'])) {
                $model->deptPermits = $map['deptPermits'];
            }
        }
        if (isset($map['deptType'])) {
            $model->deptType = $map['deptType'];
        }
        if (isset($map['empApplyJoinDept'])) {
            $model->empApplyJoinDept = $map['empApplyJoinDept'];
        }
        if (isset($map['extension'])) {
            $model->extension = $map['extension'];
        }
        if (isset($map['hideDept'])) {
            $model->hideDept = $map['hideDept'];
        }
        if (isset($map['hideSceneConfig'])) {
            $model->hideSceneConfig = hideSceneConfig::fromMap($map['hideSceneConfig']);
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['order'])) {
            $model->order = $map['order'];
        }
        if (isset($map['outerDept'])) {
            $model->outerDept = $map['outerDept'];
        }
        if (isset($map['outerDeptOnlySelf'])) {
            $model->outerDeptOnlySelf = $map['outerDeptOnlySelf'];
        }
        if (isset($map['outerPermitDepts'])) {
            if (!empty($map['outerPermitDepts'])) {
                $model->outerPermitDepts = $map['outerPermitDepts'];
            }
        }
        if (isset($map['outerPermitUsers'])) {
            if (!empty($map['outerPermitUsers'])) {
                $model->outerPermitUsers = $map['outerPermitUsers'];
            }
        }
        if (isset($map['outerSceneConfig'])) {
            $model->outerSceneConfig = outerSceneConfig::fromMap($map['outerSceneConfig']);
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
        if (isset($map['telephone'])) {
            $model->telephone = $map['telephone'];
        }
        if (isset($map['userPermits'])) {
            if (!empty($map['userPermits'])) {
                $model->userPermits = $map['userPermits'];
            }
        }

        return $model;
    }
}
