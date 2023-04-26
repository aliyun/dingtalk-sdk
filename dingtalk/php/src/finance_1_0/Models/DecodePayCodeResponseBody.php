<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class DecodePayCodeResponseBody extends Model
{
    /**
     * @example 2512345678
     *
     * @var string
     */
    public $alipayCode;

    /**
     * @example codeIdxxxxx
     *
     * @var string
     */
    public $codeId;

    /**
     * @example DT_VISITOR
     *
     * @var string
     */
    public $codeIdentity;

    /**
     * @example PURE_IDENTIFY_CODE
     *
     * @var string
     */
    public $codeType;

    /**
     * @example ding1234
     *
     * @var string
     */
    public $corpId;

    /**
     * @example {"authRules":{}}
     *
     * @var string
     */
    public $extInfo;

    /**
     * @example xxxxx
     *
     * @var string
     */
    public $outBizId;

    /**
     * @example INTERNAL_STAFF
     *
     * @var string
     */
    public $userCorpRelationType;

    /**
     * @example staffId
     *
     * @var string
     */
    public $userId;

    /**
     * @example true
     *
     * @var bool
     */
    public $userInCorp;
    protected $_name = [
        'alipayCode'           => 'alipayCode',
        'codeId'               => 'codeId',
        'codeIdentity'         => 'codeIdentity',
        'codeType'             => 'codeType',
        'corpId'               => 'corpId',
        'extInfo'              => 'extInfo',
        'outBizId'             => 'outBizId',
        'userCorpRelationType' => 'userCorpRelationType',
        'userId'               => 'userId',
        'userInCorp'           => 'userInCorp',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->alipayCode) {
            $res['alipayCode'] = $this->alipayCode;
        }
        if (null !== $this->codeId) {
            $res['codeId'] = $this->codeId;
        }
        if (null !== $this->codeIdentity) {
            $res['codeIdentity'] = $this->codeIdentity;
        }
        if (null !== $this->codeType) {
            $res['codeType'] = $this->codeType;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->extInfo) {
            $res['extInfo'] = $this->extInfo;
        }
        if (null !== $this->outBizId) {
            $res['outBizId'] = $this->outBizId;
        }
        if (null !== $this->userCorpRelationType) {
            $res['userCorpRelationType'] = $this->userCorpRelationType;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->userInCorp) {
            $res['userInCorp'] = $this->userInCorp;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DecodePayCodeResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['alipayCode'])) {
            $model->alipayCode = $map['alipayCode'];
        }
        if (isset($map['codeId'])) {
            $model->codeId = $map['codeId'];
        }
        if (isset($map['codeIdentity'])) {
            $model->codeIdentity = $map['codeIdentity'];
        }
        if (isset($map['codeType'])) {
            $model->codeType = $map['codeType'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['extInfo'])) {
            $model->extInfo = $map['extInfo'];
        }
        if (isset($map['outBizId'])) {
            $model->outBizId = $map['outBizId'];
        }
        if (isset($map['userCorpRelationType'])) {
            $model->userCorpRelationType = $map['userCorpRelationType'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['userInCorp'])) {
            $model->userInCorp = $map['userInCorp'];
        }

        return $model;
    }
}
