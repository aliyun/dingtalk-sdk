<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\CreateRecordRequest\attachmentList;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\CreateRecordRequest\fieldList;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\CreateRecordRequest\groupList;
use AlibabaCloud\Tea\Model;

class CreateRecordRequest extends Model
{
    /**
     * @var attachmentList[]
     */
    public $attachmentList;

    /**
     * @example 908608088
     *
     * @var int
     */
    public $deptId;

    /**
     * @var fieldList[]
     */
    public $fieldList;

    /**
     * @var groupList[]
     */
    public $groupList;

    /**
     * @example xxx员工劳动合同电子签署
     *
     * @var string
     */
    public $remark;

    /**
     * @example xxx有限公司
     *
     * @var string
     */
    public $signLastLegalEntityName;

    /**
     * @example xxx有限公司
     *
     * @var string
     */
    public $signLegalEntityName;

    /**
     * @description This parameter is required.
     *
     * @example CONTRACT
     *
     * @var string
     */
    public $signSource;

    /**
     * @description This parameter is required.
     *
     * @example 48510731071405348944
     *
     * @var string
     */
    public $signStartUserId;

    /**
     * @description This parameter is required.
     *
     * @example 660658
     *
     * @var string
     */
    public $signUserId;

    /**
     * @description This parameter is required.
     *
     * @example 9ad11eb3daa24a9692037079e0732f13
     *
     * @var string
     */
    public $templateId;
    protected $_name = [
        'attachmentList'          => 'attachmentList',
        'deptId'                  => 'deptId',
        'fieldList'               => 'fieldList',
        'groupList'               => 'groupList',
        'remark'                  => 'remark',
        'signLastLegalEntityName' => 'signLastLegalEntityName',
        'signLegalEntityName'     => 'signLegalEntityName',
        'signSource'              => 'signSource',
        'signStartUserId'         => 'signStartUserId',
        'signUserId'              => 'signUserId',
        'templateId'              => 'templateId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->attachmentList) {
            $res['attachmentList'] = [];
            if (null !== $this->attachmentList && \is_array($this->attachmentList)) {
                $n = 0;
                foreach ($this->attachmentList as $item) {
                    $res['attachmentList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->fieldList) {
            $res['fieldList'] = [];
            if (null !== $this->fieldList && \is_array($this->fieldList)) {
                $n = 0;
                foreach ($this->fieldList as $item) {
                    $res['fieldList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->groupList) {
            $res['groupList'] = [];
            if (null !== $this->groupList && \is_array($this->groupList)) {
                $n = 0;
                foreach ($this->groupList as $item) {
                    $res['groupList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->signLastLegalEntityName) {
            $res['signLastLegalEntityName'] = $this->signLastLegalEntityName;
        }
        if (null !== $this->signLegalEntityName) {
            $res['signLegalEntityName'] = $this->signLegalEntityName;
        }
        if (null !== $this->signSource) {
            $res['signSource'] = $this->signSource;
        }
        if (null !== $this->signStartUserId) {
            $res['signStartUserId'] = $this->signStartUserId;
        }
        if (null !== $this->signUserId) {
            $res['signUserId'] = $this->signUserId;
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateRecordRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attachmentList'])) {
            if (!empty($map['attachmentList'])) {
                $model->attachmentList = [];
                $n                     = 0;
                foreach ($map['attachmentList'] as $item) {
                    $model->attachmentList[$n++] = null !== $item ? attachmentList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['fieldList'])) {
            if (!empty($map['fieldList'])) {
                $model->fieldList = [];
                $n                = 0;
                foreach ($map['fieldList'] as $item) {
                    $model->fieldList[$n++] = null !== $item ? fieldList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['groupList'])) {
            if (!empty($map['groupList'])) {
                $model->groupList = [];
                $n                = 0;
                foreach ($map['groupList'] as $item) {
                    $model->groupList[$n++] = null !== $item ? groupList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['signLastLegalEntityName'])) {
            $model->signLastLegalEntityName = $map['signLastLegalEntityName'];
        }
        if (isset($map['signLegalEntityName'])) {
            $model->signLegalEntityName = $map['signLegalEntityName'];
        }
        if (isset($map['signSource'])) {
            $model->signSource = $map['signSource'];
        }
        if (isset($map['signStartUserId'])) {
            $model->signStartUserId = $map['signStartUserId'];
        }
        if (isset($map['signUserId'])) {
            $model->signUserId = $map['signUserId'];
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }

        return $model;
    }
}
