<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetCollegeContactDeptDetailResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetCollegeContactDeptDetailResponseBody\result\hideSceneConfig;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetCollegeContactDeptDetailResponseBody\result\outerSceneConfig;
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
    public $autoApproveApply;

    /**
     * @example 这是简介
     *
     * @var string
     */
    public $brief;

    /**
     * @example 10000
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
     * @example chat234
     *
     * @var string
     */
    public $deptGroupChatId;

    /**
     * @example 200
     *
     * @var int
     */
    public $deptId;

    /**
     * @var string[]
     */
    public $deptManagerUseridList;

    /**
     * @var int[]
     */
    public $deptPermits;

    /**
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
     * @var bool
     */
    public $groupContainSubDept;

    /**
     * @var bool
     */
    public $hideDept;

    /**
     * @var hideSceneConfig
     */
    public $hideSceneConfig;

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
    public $order;

    /**
     * @example user345
     *
     * @var string
     */
    public $orgDeptOwner;

    /**
     * @var bool
     */
    public $outerDept;

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
        'autoAddUser' => 'autoAddUser',
        'autoApproveApply' => 'autoApproveApply',
        'brief' => 'brief',
        'code' => 'code',
        'createDeptGroup' => 'createDeptGroup',
        'deptCode' => 'deptCode',
        'deptGroupChatId' => 'deptGroupChatId',
        'deptId' => 'deptId',
        'deptManagerUseridList' => 'deptManagerUseridList',
        'deptPermits' => 'deptPermits',
        'deptType' => 'deptType',
        'empApplyJoinDept' => 'empApplyJoinDept',
        'extension' => 'extension',
        'fromUnionOrg' => 'fromUnionOrg',
        'groupContainSubDept' => 'groupContainSubDept',
        'hideDept' => 'hideDept',
        'hideSceneConfig' => 'hideSceneConfig',
        'name' => 'name',
        'order' => 'order',
        'orgDeptOwner' => 'orgDeptOwner',
        'outerDept' => 'outerDept',
        'outerPermitDepts' => 'outerPermitDepts',
        'outerPermitUsers' => 'outerPermitUsers',
        'outerSceneConfig' => 'outerSceneConfig',
        'parentId' => 'parentId',
        'sourceIdentifier' => 'sourceIdentifier',
        'struId' => 'struId',
        'tags' => 'tags',
        'telephone' => 'telephone',
        'userPermits' => 'userPermits',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->autoAddUser) {
            $res['autoAddUser'] = $this->autoAddUser;
        }
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
        if (null !== $this->deptGroupChatId) {
            $res['deptGroupChatId'] = $this->deptGroupChatId;
        }
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->deptManagerUseridList) {
            $res['deptManagerUseridList'] = $this->deptManagerUseridList;
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
        if (null !== $this->fromUnionOrg) {
            $res['fromUnionOrg'] = $this->fromUnionOrg;
        }
        if (null !== $this->groupContainSubDept) {
            $res['groupContainSubDept'] = $this->groupContainSubDept;
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
        if (null !== $this->orgDeptOwner) {
            $res['orgDeptOwner'] = $this->orgDeptOwner;
        }
        if (null !== $this->outerDept) {
            $res['outerDept'] = $this->outerDept;
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
        if (null !== $this->tags) {
            $res['tags'] = $this->tags;
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
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['autoAddUser'])) {
            $model->autoAddUser = $map['autoAddUser'];
        }
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
        if (isset($map['deptGroupChatId'])) {
            $model->deptGroupChatId = $map['deptGroupChatId'];
        }
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['deptManagerUseridList'])) {
            if (!empty($map['deptManagerUseridList'])) {
                $model->deptManagerUseridList = $map['deptManagerUseridList'];
            }
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
        if (isset($map['fromUnionOrg'])) {
            $model->fromUnionOrg = $map['fromUnionOrg'];
        }
        if (isset($map['groupContainSubDept'])) {
            $model->groupContainSubDept = $map['groupContainSubDept'];
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
        if (isset($map['orgDeptOwner'])) {
            $model->orgDeptOwner = $map['orgDeptOwner'];
        }
        if (isset($map['outerDept'])) {
            $model->outerDept = $map['outerDept'];
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
        if (isset($map['tags'])) {
            $model->tags = $map['tags'];
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
