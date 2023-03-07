<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddCustomerTrackRequest extends Model
{
    /**
     * @description 动态内容（明文未脱敏内容），markdown格式，必填。客户动态列表页的展示规则：如果有maskedContent字段对应动态脱敏内容则优先展示动态脱敏内容，否则优先展示本content字段内容。当显示了动态脱敏内容时用户可以点击页面按钮来查看动态未脱敏明文内容。
     *
     * @var string
     */
    public $content;

    /**
     * @description 客户ID
     *
     * @var string
     */
    public $customerId;

    /**
     * @description 任意业务自定义的数据，可空
     *
     * @var string
     */
    public $extraBizInfo;

    /**
     * @description 幂等key，5分钟内避免重复写入，保证幂等，可空
     *
     * @var string
     */
    public $idempotentKey;

    /**
     * @description 动态脱敏内容，markdown格式，非必填。客户动态列表页的展示规则：如果本字段有值，则优先展示本字段的动态脱敏内容，否则展示content字段内容。当显示了动态脱敏内容时用户可以点击页面按钮来查看动态未脱敏明文内容。
     *
     * @var string
     */
    public $maskedContent;

    /**
     * @description 操作人userId
     *
     * @var string
     */
    public $operatorUserId;

    /**
     * @description 关系类型
     *
     * @var string
     */
    public $relationType;

    /**
     * @description 动态标题
     *
     * @var string
     */
    public $title;

    /**
     * @description 动态的类型
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
