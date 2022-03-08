<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models;

use AlibabaCloud\Tea\Model;

class BillSettementFlightRequest extends Model
{
    /**
     * @description 类目：机酒火车 1：机票； 2：酒店； 4：用车 6：商旅火车票
     *
     * @var int
     */
    public $category;

    /**
     * @description 第三方企业ID
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 页数，从1开始
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description 每页数据量，默认100，最高500
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description 记账更新结束日期
     *
     * @var string
     */
    public $periodEnd;

    /**
     * @description 记账更新开始日期
     *
     * @var string
     */
    public $periodStart;
    protected $_name = [
        'category'    => 'category',
        'corpId'      => 'corpId',
        'pageNumber'  => 'pageNumber',
        'pageSize'    => 'pageSize',
        'periodEnd'   => 'periodEnd',
        'periodStart' => 'periodStart',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->category) {
            $res['category'] = $this->category;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->periodEnd) {
            $res['periodEnd'] = $this->periodEnd;
        }
        if (null !== $this->periodStart) {
            $res['periodStart'] = $this->periodStart;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BillSettementFlightRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['category'])) {
            $model->category = $map['category'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['periodEnd'])) {
            $model->periodEnd = $map['periodEnd'];
        }
        if (isset($map['periodStart'])) {
            $model->periodStart = $map['periodStart'];
        }

        return $model;
    }
}
