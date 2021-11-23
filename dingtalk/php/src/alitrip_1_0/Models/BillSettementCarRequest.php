<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models;

use AlibabaCloud\Tea\Model;

class BillSettementCarRequest extends Model
{
    /**
     * @var string
     */
    public $corpId;

    /**
     * @var int
     */
    public $category;

    /**
     * @var int
     */
    public $pageSize;

    /**
     * @var string
     */
    public $periodStart;

    /**
     * @var string
     */
    public $periodEnd;

    /**
     * @var int
     */
    public $pageNumber;
    protected $_name = [
        'corpId'      => 'corpId',
        'category'    => 'category',
        'pageSize'    => 'pageSize',
        'periodStart' => 'periodStart',
        'periodEnd'   => 'periodEnd',
        'pageNumber'  => 'pageNumber',
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
        if (null !== $this->periodEnd) {
            $res['periodEnd'] = $this->periodEnd;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BillSettementCarRequest
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
        if (isset($map['periodEnd'])) {
            $model->periodEnd = $map['periodEnd'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }

        return $model;
    }
}
