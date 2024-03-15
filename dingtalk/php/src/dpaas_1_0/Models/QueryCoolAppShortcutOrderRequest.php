<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdpaas_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryCoolAppShortcutOrderRequest extends Model
{
    /**
     * @example cidxxx
     *
     * @var string
     */
    public $conversationId;

    /**
     * @example staff1
     *
     * @var string
     */
    public $operatorId;

    /**
     * @example templateId1
     *
     * @var string
     */
    public $templateId;
    protected $_name = [
        'conversationId' => 'conversationId',
        'operatorId'     => 'operatorId',
        'templateId'     => 'templateId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->conversationId) {
            $res['conversationId'] = $this->conversationId;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryCoolAppShortcutOrderRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['conversationId'])) {
            $model->conversationId = $map['conversationId'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }

        return $model;
    }
}
