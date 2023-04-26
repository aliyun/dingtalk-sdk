<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models;

use AlibabaCloud\Tea\Model;

class BillSettementFlightRequest extends Model
{
    /**
     * @example 1
     *
     * @var int
     */
    public $category;

    /**
     * @example corpx
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 1
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @example 100
     *
     * @var int
     */
    public $pageSize;

    /**
     * @example 2021-10-01
     *
     * @var string
     */
    public $periodEnd;

    /**
     * @example 2021-10-01
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
