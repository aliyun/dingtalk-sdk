<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetDingReportDeptSummaryRequest extends Model
{
    /**
     * @description 启始数据游标
     *
     * @var int
     */
    public $pageStart;

    /**
     * @description 每页包含的数据条数
     *
     * @var int
     */
    public $pageSize;
    protected $_name = [
        'pageStart' => 'pageStart',
        'pageSize'  => 'pageSize',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->pageStart) {
            $res['pageStart'] = $this->pageStart;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetDingReportDeptSummaryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['pageStart'])) {
            $model->pageStart = $map['pageStart'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }

        return $model;
    }
}
