<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QuerySubjectPublicRiskResponseBody\result\risks\businessRisk\subRisks;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QuerySubjectPublicRiskResponseBody\result\risks\businessRisk\subRisks\administrativePunishment\columns;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QuerySubjectPublicRiskResponseBody\result\risks\businessRisk\subRisks\administrativePunishment\items;
use AlibabaCloud\Tea\Model;

class administrativePunishment extends Model
{
    /**
     * @var columns[]
     */
    public $columns;

    /**
     * @var items[]
     */
    public $items;

    /**
     * @var string
     */
    public $noticeText;

    /**
     * @var string
     */
    public $subRiskName;

    /**
     * @var int
     */
    public $subRiskNumber;

    /**
     * @var string
     */
    public $subRiskType;
    protected $_name = [
        'columns' => 'columns',
        'items' => 'items',
        'noticeText' => 'noticeText',
        'subRiskName' => 'subRiskName',
        'subRiskNumber' => 'subRiskNumber',
        'subRiskType' => 'subRiskType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->columns) {
            $res['columns'] = [];
            if (null !== $this->columns && \is_array($this->columns)) {
                $n = 0;
                foreach ($this->columns as $item) {
                    $res['columns'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->items) {
            $res['items'] = [];
            if (null !== $this->items && \is_array($this->items)) {
                $n = 0;
                foreach ($this->items as $item) {
                    $res['items'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->noticeText) {
            $res['noticeText'] = $this->noticeText;
        }
        if (null !== $this->subRiskName) {
            $res['subRiskName'] = $this->subRiskName;
        }
        if (null !== $this->subRiskNumber) {
            $res['subRiskNumber'] = $this->subRiskNumber;
        }
        if (null !== $this->subRiskType) {
            $res['subRiskType'] = $this->subRiskType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return administrativePunishment
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['columns'])) {
            if (!empty($map['columns'])) {
                $model->columns = [];
                $n = 0;
                foreach ($map['columns'] as $item) {
                    $model->columns[$n++] = null !== $item ? columns::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['items'])) {
            if (!empty($map['items'])) {
                $model->items = [];
                $n = 0;
                foreach ($map['items'] as $item) {
                    $model->items[$n++] = null !== $item ? items::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['noticeText'])) {
            $model->noticeText = $map['noticeText'];
        }
        if (isset($map['subRiskName'])) {
            $model->subRiskName = $map['subRiskName'];
        }
        if (isset($map['subRiskNumber'])) {
            $model->subRiskNumber = $map['subRiskNumber'];
        }
        if (isset($map['subRiskType'])) {
            $model->subRiskType = $map['subRiskType'];
        }

        return $model;
    }
}
