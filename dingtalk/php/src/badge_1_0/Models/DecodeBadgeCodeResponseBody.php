<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models;

use AlibabaCloud\Tea\Model;

class DecodeBadgeCodeResponseBody extends Model
{
    /**
     * @description 企业id
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 员工id
     *
     * @var string
     */
    public $userId;

    /**
     * @description 码类型
     *
     * @var string
     */
    public $codeType;

    /**
     * @description 支付宝付款码
     *
     * @var string
     */
    public $alipayCode;

    /**
     * @description 用户和企业关系
     *
     * @var string
     */
    public $userCorpRelationType;

    /**
     * @description 码标识，工牌码：DT_IDENTITY，访客码：DT_VISITOR，会展码：DT_CONFERENCE
     *
     * @var string
     */
    public $codeIdentity;

    /**
     * @description 码ID，对于访客或会展码等静态码值返回
     *
     * @var string
     */
    public $codeId;

    /**
     * @description 外部业务ID，值为调用创建工牌码接口传入的requestId
     *
     * @var string
     */
    public $outBizId;
    protected $_name = [
        'corpId'               => 'corpId',
        'userId'               => 'userId',
        'codeType'             => 'codeType',
        'alipayCode'           => 'alipayCode',
        'userCorpRelationType' => 'userCorpRelationType',
        'codeIdentity'         => 'codeIdentity',
        'codeId'               => 'codeId',
        'outBizId'             => 'outBizId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->codeType) {
            $res['codeType'] = $this->codeType;
        }
        if (null !== $this->alipayCode) {
            $res['alipayCode'] = $this->alipayCode;
        }
        if (null !== $this->userCorpRelationType) {
            $res['userCorpRelationType'] = $this->userCorpRelationType;
        }
        if (null !== $this->codeIdentity) {
            $res['codeIdentity'] = $this->codeIdentity;
        }
        if (null !== $this->codeId) {
            $res['codeId'] = $this->codeId;
        }
        if (null !== $this->outBizId) {
            $res['outBizId'] = $this->outBizId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DecodeBadgeCodeResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['codeType'])) {
            $model->codeType = $map['codeType'];
        }
        if (isset($map['alipayCode'])) {
            $model->alipayCode = $map['alipayCode'];
        }
        if (isset($map['userCorpRelationType'])) {
            $model->userCorpRelationType = $map['userCorpRelationType'];
        }
        if (isset($map['codeIdentity'])) {
            $model->codeIdentity = $map['codeIdentity'];
        }
        if (isset($map['codeId'])) {
            $model->codeId = $map['codeId'];
        }
        if (isset($map['outBizId'])) {
            $model->outBizId = $map['outBizId'];
        }

        return $model;
    }
}
