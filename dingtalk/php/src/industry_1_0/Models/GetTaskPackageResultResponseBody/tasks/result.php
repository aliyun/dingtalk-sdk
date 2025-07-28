<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\GetTaskPackageResultResponseBody\tasks;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\GetTaskPackageResultResponseBody\tasks\result\items;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $audioText;

    /**
     * @var string
     */
    public $audioTextFormatted;

    /**
     * @var string
     */
    public $date;

    /**
     * @var string
     */
    public $desc;

    /**
     * @var string
     */
    public $formName;

    /**
     * @var int
     */
    public $id;

    /**
     * @var items[]
     */
    public $items;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $rawData;

    /**
     * @var string
     */
    public $summary;

    /**
     * @var int
     */
    public $total;
    protected $_name = [
        'audioText' => 'audioText',
        'audioTextFormatted' => 'audioTextFormatted',
        'date' => 'date',
        'desc' => 'desc',
        'formName' => 'formName',
        'id' => 'id',
        'items' => 'items',
        'name' => 'name',
        'rawData' => 'rawData',
        'summary' => 'summary',
        'total' => 'total',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->audioText) {
            $res['audioText'] = $this->audioText;
        }
        if (null !== $this->audioTextFormatted) {
            $res['audioTextFormatted'] = $this->audioTextFormatted;
        }
        if (null !== $this->date) {
            $res['date'] = $this->date;
        }
        if (null !== $this->desc) {
            $res['desc'] = $this->desc;
        }
        if (null !== $this->formName) {
            $res['formName'] = $this->formName;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
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
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->rawData) {
            $res['rawData'] = $this->rawData;
        }
        if (null !== $this->summary) {
            $res['summary'] = $this->summary;
        }
        if (null !== $this->total) {
            $res['total'] = $this->total;
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
        if (isset($map['audioText'])) {
            $model->audioText = $map['audioText'];
        }
        if (isset($map['audioTextFormatted'])) {
            $model->audioTextFormatted = $map['audioTextFormatted'];
        }
        if (isset($map['date'])) {
            $model->date = $map['date'];
        }
        if (isset($map['desc'])) {
            $model->desc = $map['desc'];
        }
        if (isset($map['formName'])) {
            $model->formName = $map['formName'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
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
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['rawData'])) {
            $model->rawData = $map['rawData'];
        }
        if (isset($map['summary'])) {
            $model->summary = $map['summary'];
        }
        if (isset($map['total'])) {
            $model->total = $map['total'];
        }

        return $model;
    }
}
