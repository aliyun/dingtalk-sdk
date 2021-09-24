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
    protected $_name = [
        'corpId'               => 'corpId',
        'userId'               => 'userId',
        'codeType'             => 'codeType',
        'alipayCode'           => 'alipayCode',
        'userCorpRelationType' => 'userCorpRelationType',
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

        return $model;
    }
}
