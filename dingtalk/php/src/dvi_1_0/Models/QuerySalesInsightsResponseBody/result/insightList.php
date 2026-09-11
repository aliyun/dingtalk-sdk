<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QuerySalesInsightsResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QuerySalesInsightsResponseBody\result\insightList\commonSummary;
use AlibabaCloud\Tea\Model;

class insightList extends Model
{
    /**
     * @var commonSummary[]
     */
    public $commonSummary;

    /**
     * @var string
     */
    public $name;
    protected $_name = [
        'commonSummary' => 'commonSummary',
        'name' => 'name',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->commonSummary) {
            $res['commonSummary'] = [];
            if (null !== $this->commonSummary && \is_array($this->commonSummary)) {
                $n = 0;
                foreach ($this->commonSummary as $item) {
                    $res['commonSummary'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return insightList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['commonSummary'])) {
            if (!empty($map['commonSummary'])) {
                $model->commonSummary = [];
                $n = 0;
                foreach ($map['commonSummary'] as $item) {
                    $model->commonSummary[$n++] = null !== $item ? commonSummary::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
