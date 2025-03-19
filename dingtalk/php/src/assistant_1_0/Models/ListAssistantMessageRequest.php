<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListAssistantMessageRequest extends Model
{
    /**
     * @var int
     */
    public $limit;

    /**
     * @var string
     */
    public $order;

    /**
     * @var string
     */
    public $runId;
    protected $_name = [
        'limit' => 'limit',
        'order' => 'order',
        'runId' => 'runId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->limit) {
            $res['limit'] = $this->limit;
        }
        if (null !== $this->order) {
            $res['order'] = $this->order;
        }
        if (null !== $this->runId) {
            $res['runId'] = $this->runId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListAssistantMessageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['limit'])) {
            $model->limit = $map['limit'];
        }
        if (isset($map['order'])) {
            $model->order = $map['order'];
        }
        if (isset($map['runId'])) {
            $model->runId = $map['runId'];
        }

        return $model;
    }
}
