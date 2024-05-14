<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddCustomerTrackRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example [华佗](http://******)创建了合同：**今日合同**
     *
     * @var string
     */
    public $content;

    /**
     * @description This parameter is required.
     *
     * @example fb037d68-c1bd-4be2-8c3b-6739261d1332
     *
     * @var string
     */
    public $customerId;

    /**
     * @example {"bizId":"1"}
     *
     * @var string
     */
    public $extraBizInfo;

    /**
     * @example fb037d68-c1bd-4be2-8c3b-6739261d1332-1
     *
     * @var string
     */
    public $idempotentKey;

    /**
     * @example [华佗](http://******)创建了合同：**今日合同**
     *
     * @var string
     */
    public $maskedContent;

    /**
     * @description This parameter is required.
     *
     * @example manager1120
     *
     * @var string
     */
    public $operatorUserId;

    /**
     * @description This parameter is required.
     *
     * @example crm_customer
     *
     * @var string
     */
    public $relationType;

    /**
     * @description This parameter is required.
     *
     * @example 创建合同
     *
     * @var string
     */
    public $title;

    /**
     * @description This parameter is required.
     *
     * @example 212
     *
     * @var int
     */
    public $type;
    protected $_name = [
        'content'        => 'content',
        'customerId'     => 'customerId',
        'extraBizInfo'   => 'extraBizInfo',
        'idempotentKey'  => 'idempotentKey',
        'maskedContent'  => 'maskedContent',
        'operatorUserId' => 'operatorUserId',
        'relationType'   => 'relationType',
        'title'          => 'title',
        'type'           => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->customerId) {
            $res['customerId'] = $this->customerId;
        }
        if (null !== $this->extraBizInfo) {
            $res['extraBizInfo'] = $this->extraBizInfo;
        }
        if (null !== $this->idempotentKey) {
            $res['idempotentKey'] = $this->idempotentKey;
        }
        if (null !== $this->maskedContent) {
            $res['maskedContent'] = $this->maskedContent;
        }
        if (null !== $this->operatorUserId) {
            $res['operatorUserId'] = $this->operatorUserId;
        }
        if (null !== $this->relationType) {
            $res['relationType'] = $this->relationType;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddCustomerTrackRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['customerId'])) {
            $model->customerId = $map['customerId'];
        }
        if (isset($map['extraBizInfo'])) {
            $model->extraBizInfo = $map['extraBizInfo'];
        }
        if (isset($map['idempotentKey'])) {
            $model->idempotentKey = $map['idempotentKey'];
        }
        if (isset($map['maskedContent'])) {
            $model->maskedContent = $map['maskedContent'];
        }
        if (isset($map['operatorUserId'])) {
            $model->operatorUserId = $map['operatorUserId'];
        }
        if (isset($map['relationType'])) {
            $model->relationType = $map['relationType'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
