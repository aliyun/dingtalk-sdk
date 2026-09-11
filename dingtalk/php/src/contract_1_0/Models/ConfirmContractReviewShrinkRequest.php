<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models;

use AlibabaCloud\Tea\Model;

class ConfirmContractReviewShrinkRequest extends Model
{
    /**
     * @var string
     */
    public $action;

    /**
     * @var string
     */
    public $checklistId;

    /**
     * @var string
     */
    public $contractType;

    /**
     * @var string
     */
    public $customRulesShrink;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $reviewId;

    /**
     * @var string
     */
    public $scale;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $sessionId;

    /**
     * @var string
     */
    public $standpoint;
    protected $_name = [
        'action' => 'action',
        'checklistId' => 'checklist_id',
        'contractType' => 'contract_type',
        'customRulesShrink' => 'custom_rules',
        'reviewId' => 'review_id',
        'scale' => 'scale',
        'sessionId' => 'session_id',
        'standpoint' => 'standpoint',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->action) {
            $res['action'] = $this->action;
        }
        if (null !== $this->checklistId) {
            $res['checklist_id'] = $this->checklistId;
        }
        if (null !== $this->contractType) {
            $res['contract_type'] = $this->contractType;
        }
        if (null !== $this->customRulesShrink) {
            $res['custom_rules'] = $this->customRulesShrink;
        }
        if (null !== $this->reviewId) {
            $res['review_id'] = $this->reviewId;
        }
        if (null !== $this->scale) {
            $res['scale'] = $this->scale;
        }
        if (null !== $this->sessionId) {
            $res['session_id'] = $this->sessionId;
        }
        if (null !== $this->standpoint) {
            $res['standpoint'] = $this->standpoint;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ConfirmContractReviewShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['action'])) {
            $model->action = $map['action'];
        }
        if (isset($map['checklist_id'])) {
            $model->checklistId = $map['checklist_id'];
        }
        if (isset($map['contract_type'])) {
            $model->contractType = $map['contract_type'];
        }
        if (isset($map['custom_rules'])) {
            $model->customRulesShrink = $map['custom_rules'];
        }
        if (isset($map['review_id'])) {
            $model->reviewId = $map['review_id'];
        }
        if (isset($map['scale'])) {
            $model->scale = $map['scale'];
        }
        if (isset($map['session_id'])) {
            $model->sessionId = $map['session_id'];
        }
        if (isset($map['standpoint'])) {
            $model->standpoint = $map['standpoint'];
        }

        return $model;
    }
}
