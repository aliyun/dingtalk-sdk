<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models;

use AlibabaCloud\Tea\Model;

class BillSettementFlightRequest extends Model
{
    /**
     * @description 第三方企业ID
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 类目：机酒火车 1：机票； 2：酒店； 4：用车 6：商旅火车票
     *
     * @var int
     */
    public $category;

    /**
     * @description 每页数据量，默认100，最高500
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description 记账更新开始日期
     *
     * @var string
     */
    public $periodStart;

    /**
     * @description 页数，从1开始
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description 记账更新结束日期
     *
     * @var string
     */
    public $periodEnd;
    protected $_name = [
        'corpId'      => 'corpId',
        'category'    => 'category',
        'pageSize'    => 'pageSize',
        'periodStart' => 'periodStart',
        'pageNumber'  => 'pageNumber',
        'periodEnd'   => 'periodEnd',
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
        if (null !== $this->category) {
            $res['category'] = $this->category;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->periodStart) {
            $res['periodStart'] = $this->periodStart;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->periodEnd) {
            $res['periodEnd'] = $this->periodEnd;
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
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['category'])) {
            $model->category = $map['category'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['periodStart'])) {
            $model->periodStart = $map['periodStart'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['periodEnd'])) {
            $model->periodEnd = $map['periodEnd'];
        }

        return $model;
    }
}
