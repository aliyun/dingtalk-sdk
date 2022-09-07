<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ListProcessInstanceIdsResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 审批实例ID列表。
     *
     * @var string[]
     */
    public $list;

    /**
     * @description 表示下次查询的游标，当返回结果没有该字段时表示没有更多数据了。
     *
     * @var string
     */
    public $nextToken;
    protected $_name = [
        'list'      => 'list',
        'nextToken' => 'nextToken',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->list) {
            $res['list'] = $this->list;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['list'])) {
            if (!empty($map['list'])) {
                $model->list = $map['list'];
            }
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }

        return $model;
    }
}
