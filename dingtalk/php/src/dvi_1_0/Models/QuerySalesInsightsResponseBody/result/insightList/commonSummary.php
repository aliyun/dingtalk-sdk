<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QuerySalesInsightsResponseBody\result\insightList;

use AlibabaCloud\Tea\Model;

class commonSummary extends Model
{
    /**
     * @var string
     */
    public $content;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $priority;

    /**
     * @var string
     */
    public $priorityText;
    protected $_name = [
        'content' => 'content',
        'name' => 'name',
        'priority' => 'priority',
        'priorityText' => 'priorityText',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->priority) {
            $res['priority'] = $this->priority;
        }
        if (null !== $this->priorityText) {
            $res['priorityText'] = $this->priorityText;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return commonSummary
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['priority'])) {
            $model->priority = $map['priority'];
        }
        if (isset($map['priorityText'])) {
            $model->priorityText = $map['priorityText'];
        }

        return $model;
    }
}
