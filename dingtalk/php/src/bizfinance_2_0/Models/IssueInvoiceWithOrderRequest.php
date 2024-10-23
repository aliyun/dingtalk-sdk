<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\IssueInvoiceWithOrderRequest\content;
use AlibabaCloud\Tea\Model;

class IssueInvoiceWithOrderRequest extends Model
{
    /**
     * @var content
     */
    public $content;

    /**
     * @var string
     */
    public $financeAppKey;

    /**
     * @var string
     */
    public $operator;

    /**
     * @var string
     */
    public $signature;
    protected $_name = [
        'content'       => 'content',
        'financeAppKey' => 'financeAppKey',
        'operator'      => 'operator',
        'signature'     => 'signature',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = null !== $this->content ? $this->content->toMap() : null;
        }
        if (null !== $this->financeAppKey) {
            $res['financeAppKey'] = $this->financeAppKey;
        }
        if (null !== $this->operator) {
            $res['operator'] = $this->operator;
        }
        if (null !== $this->signature) {
            $res['signature'] = $this->signature;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return IssueInvoiceWithOrderRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = content::fromMap($map['content']);
        }
        if (isset($map['financeAppKey'])) {
            $model->financeAppKey = $map['financeAppKey'];
        }
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }
        if (isset($map['signature'])) {
            $model->signature = $map['signature'];
        }

        return $model;
    }
}
