<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class AnnualCertificationAuditRequest extends Model
{
    /**
     * @var string
     */
    public $applicantMobile;

    /**
     * @var string
     */
    public $applicantName;

    /**
     * @var string
     */
    public $applicationLetter;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $authStatus;

    /**
     * @var int
     */
    public $certificateType;

    /**
     * @var string
     */
    public $corpName;

    /**
     * @var string
     */
    public $depositaryBank;

    /**
     * @var string
     */
    public $extension;

    /**
     * @var string
     */
    public $legalPerson;

    /**
     * @var string
     */
    public $licenseNumber;

    /**
     * @var string
     */
    public $licenseUrl;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $orderId;

    /**
     * @var string
     */
    public $publicAccount;

    /**
     * @var string
     */
    public $reasonCode;

    /**
     * @var string
     */
    public $reasonMsg;

    /**
     * @var string
     */
    public $tag;
    protected $_name = [
        'applicantMobile' => 'applicantMobile',
        'applicantName' => 'applicantName',
        'applicationLetter' => 'applicationLetter',
        'authStatus' => 'authStatus',
        'certificateType' => 'certificateType',
        'corpName' => 'corpName',
        'depositaryBank' => 'depositaryBank',
        'extension' => 'extension',
        'legalPerson' => 'legalPerson',
        'licenseNumber' => 'licenseNumber',
        'licenseUrl' => 'licenseUrl',
        'orderId' => 'orderId',
        'publicAccount' => 'publicAccount',
        'reasonCode' => 'reasonCode',
        'reasonMsg' => 'reasonMsg',
        'tag' => 'tag',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->applicantMobile) {
            $res['applicantMobile'] = $this->applicantMobile;
        }
        if (null !== $this->applicantName) {
            $res['applicantName'] = $this->applicantName;
        }
        if (null !== $this->applicationLetter) {
            $res['applicationLetter'] = $this->applicationLetter;
        }
        if (null !== $this->authStatus) {
            $res['authStatus'] = $this->authStatus;
        }
        if (null !== $this->certificateType) {
            $res['certificateType'] = $this->certificateType;
        }
        if (null !== $this->corpName) {
            $res['corpName'] = $this->corpName;
        }
        if (null !== $this->depositaryBank) {
            $res['depositaryBank'] = $this->depositaryBank;
        }
        if (null !== $this->extension) {
            $res['extension'] = $this->extension;
        }
        if (null !== $this->legalPerson) {
            $res['legalPerson'] = $this->legalPerson;
        }
        if (null !== $this->licenseNumber) {
            $res['licenseNumber'] = $this->licenseNumber;
        }
        if (null !== $this->licenseUrl) {
            $res['licenseUrl'] = $this->licenseUrl;
        }
        if (null !== $this->orderId) {
            $res['orderId'] = $this->orderId;
        }
        if (null !== $this->publicAccount) {
            $res['publicAccount'] = $this->publicAccount;
        }
        if (null !== $this->reasonCode) {
            $res['reasonCode'] = $this->reasonCode;
        }
        if (null !== $this->reasonMsg) {
            $res['reasonMsg'] = $this->reasonMsg;
        }
        if (null !== $this->tag) {
            $res['tag'] = $this->tag;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AnnualCertificationAuditRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['applicantMobile'])) {
            $model->applicantMobile = $map['applicantMobile'];
        }
        if (isset($map['applicantName'])) {
            $model->applicantName = $map['applicantName'];
        }
        if (isset($map['applicationLetter'])) {
            $model->applicationLetter = $map['applicationLetter'];
        }
        if (isset($map['authStatus'])) {
            $model->authStatus = $map['authStatus'];
        }
        if (isset($map['certificateType'])) {
            $model->certificateType = $map['certificateType'];
        }
        if (isset($map['corpName'])) {
            $model->corpName = $map['corpName'];
        }
        if (isset($map['depositaryBank'])) {
            $model->depositaryBank = $map['depositaryBank'];
        }
        if (isset($map['extension'])) {
            $model->extension = $map['extension'];
        }
        if (isset($map['legalPerson'])) {
            $model->legalPerson = $map['legalPerson'];
        }
        if (isset($map['licenseNumber'])) {
            $model->licenseNumber = $map['licenseNumber'];
        }
        if (isset($map['licenseUrl'])) {
            $model->licenseUrl = $map['licenseUrl'];
        }
        if (isset($map['orderId'])) {
            $model->orderId = $map['orderId'];
        }
        if (isset($map['publicAccount'])) {
            $model->publicAccount = $map['publicAccount'];
        }
        if (isset($map['reasonCode'])) {
            $model->reasonCode = $map['reasonCode'];
        }
        if (isset($map['reasonMsg'])) {
            $model->reasonMsg = $map['reasonMsg'];
        }
        if (isset($map['tag'])) {
            $model->tag = $map['tag'];
        }

        return $model;
    }
}
