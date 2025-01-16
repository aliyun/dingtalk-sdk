<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetProcessDesignByCodeResponseBody;

use AlibabaCloud\Tea\Model;

class props extends Model
{
    /**
     * @var bool
     */
    public $allowCollaboration;

    /**
     * @var bool
     */
    public $allowTemporaryStorage;

    /**
     * @var bool
     */
    public $allowWithdraw;

    /**
     * @example FORM-xxx
     *
     * @var string
     */
    public $bindingForm;

    /**
     * @var bool
     */
    public $noRecordRecall;

    /**
     * @example TPROC--BDC66HB1FIPNPCMNE5VV787RY4D5327NBKTZL0
     *
     * @var string
     */
    public $processCode;

    /**
     * @example https://xxx
     *
     * @var string
     */
    public $processDetailUrl;

    /**
     * @example https://xxx
     *
     * @var string
     */
    public $processInitUrl;

    /**
     * @example https://xxx
     *
     * @var string
     */
    public $processMobileDetailUrl;

    /**
     * @var bool
     */
    public $stopAssociationRulesIfFailed;
    protected $_name = [
        'allowCollaboration'           => 'allowCollaboration',
        'allowTemporaryStorage'        => 'allowTemporaryStorage',
        'allowWithdraw'                => 'allowWithdraw',
        'bindingForm'                  => 'bindingForm',
        'noRecordRecall'               => 'noRecordRecall',
        'processCode'                  => 'processCode',
        'processDetailUrl'             => 'processDetailUrl',
        'processInitUrl'               => 'processInitUrl',
        'processMobileDetailUrl'       => 'processMobileDetailUrl',
        'stopAssociationRulesIfFailed' => 'stopAssociationRulesIfFailed',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->allowCollaboration) {
            $res['allowCollaboration'] = $this->allowCollaboration;
        }
        if (null !== $this->allowTemporaryStorage) {
            $res['allowTemporaryStorage'] = $this->allowTemporaryStorage;
        }
        if (null !== $this->allowWithdraw) {
            $res['allowWithdraw'] = $this->allowWithdraw;
        }
        if (null !== $this->bindingForm) {
            $res['bindingForm'] = $this->bindingForm;
        }
        if (null !== $this->noRecordRecall) {
            $res['noRecordRecall'] = $this->noRecordRecall;
        }
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
        }
        if (null !== $this->processDetailUrl) {
            $res['processDetailUrl'] = $this->processDetailUrl;
        }
        if (null !== $this->processInitUrl) {
            $res['processInitUrl'] = $this->processInitUrl;
        }
        if (null !== $this->processMobileDetailUrl) {
            $res['processMobileDetailUrl'] = $this->processMobileDetailUrl;
        }
        if (null !== $this->stopAssociationRulesIfFailed) {
            $res['stopAssociationRulesIfFailed'] = $this->stopAssociationRulesIfFailed;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return props
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['allowCollaboration'])) {
            $model->allowCollaboration = $map['allowCollaboration'];
        }
        if (isset($map['allowTemporaryStorage'])) {
            $model->allowTemporaryStorage = $map['allowTemporaryStorage'];
        }
        if (isset($map['allowWithdraw'])) {
            $model->allowWithdraw = $map['allowWithdraw'];
        }
        if (isset($map['bindingForm'])) {
            $model->bindingForm = $map['bindingForm'];
        }
        if (isset($map['noRecordRecall'])) {
            $model->noRecordRecall = $map['noRecordRecall'];
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }
        if (isset($map['processDetailUrl'])) {
            $model->processDetailUrl = $map['processDetailUrl'];
        }
        if (isset($map['processInitUrl'])) {
            $model->processInitUrl = $map['processInitUrl'];
        }
        if (isset($map['processMobileDetailUrl'])) {
            $model->processMobileDetailUrl = $map['processMobileDetailUrl'];
        }
        if (isset($map['stopAssociationRulesIfFailed'])) {
            $model->stopAssociationRulesIfFailed = $map['stopAssociationRulesIfFailed'];
        }

        return $model;
    }
}
