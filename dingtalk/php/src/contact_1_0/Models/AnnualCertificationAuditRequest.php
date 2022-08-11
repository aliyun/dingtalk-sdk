<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class AnnualCertificationAuditRequest extends Model
{
    /**
     * @description 申请人手机号。
     *
     * @var string
     */
    public $applicantMobile;

    /**
     * @description 申请人姓名。
     *
     * @var string
     */
    public $applicantName;

    /**
     * @description 认证/修改认证授权函
     *
     * @var string
     */
    public $applicationLetter;

    /**
     * @description 结果状态
     * 3:审核通过
     * @var int
     */
    public $authStatus;

    /**
     * @description 证书类型：
     *
     * 1：其它
     * @var int
     */
    public $certificateType;

    /**
     * @description 用户提交的企业名称
     *
     * @var string
     */
    public $corpName;

    /**
     * @description 开户行。
     *
     * @var string
     */
    public $depositaryBank;

    /**
     * @description 扩展字段，json格式传递，传递上面字段的额外字段。
     *
     * @var string
     */
    public $extension;

    /**
     * @description 法人姓名。
     *
     * @var string
     */
    public $legalPerson;

    /**
     * @description 证件号：
     *
     * 组织机构代码证号（格式11111111-1）
     * @var string
     */
    public $licenseNumber;

    /**
     * @description 企业证件照片url。
     *
     * @var string
     */
    public $licenseUrl;

    /**
     * @description 订单ID
     *
     * @var string
     */
    public $orderId;

    /**
     * @description 对公账号。
     *
     * @var string
     */
    public $publicAccount;

    /**
     * @description 失败原因，认证中预警 和 认证中需要补充材料以及认证失败时需要提供。
     *
     * @var string
     */
    public $reasonCode;

    /**
     * @var string
     */
    public $reasonMsg;

    /**
     * @description 送审打标类型：
     *
     * "AV"：四要素未通过
     * @var string
     */
    public $tag;
    protected $_name = [
        'applicantMobile'   => 'applicantMobile',
        'applicantName'     => 'applicantName',
        'applicationLetter' => 'applicationLetter',
        'authStatus'        => 'authStatus',
        'certificateType'   => 'certificateType',
        'corpName'          => 'corpName',
        'depositaryBank'    => 'depositaryBank',
        'extension'         => 'extension',
        'legalPerson'       => 'legalPerson',
        'licenseNumber'     => 'licenseNumber',
        'licenseUrl'        => 'licenseUrl',
        'orderId'           => 'orderId',
        'publicAccount'     => 'publicAccount',
        'reasonCode'        => 'reasonCode',
        'reasonMsg'         => 'reasonMsg',
        'tag'               => 'tag',
    ];

    public function validate()
    {
    }

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
