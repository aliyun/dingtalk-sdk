<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryOfficialDatasetListResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryOfficialDatasetListResponseBody\result\rows;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var rows[]
     */
    public $rows;

    /**
     * @var int
     */
    public $totalCount;
    protected $_name = [
        'rows'       => 'rows',
        'totalCount' => 'totalCount',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->rows) {
            $res['rows'] = [];
            if (null !== $this->rows && \is_array($this->rows)) {
                $n = 0;
                foreach ($this->rows as $item) {
                    $res['rows'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->totalCount) {
            $res['totalCount'] = $this->totalCount;
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
        if (isset($map['rows'])) {
            if (!empty($map['rows'])) {
                $model->rows = [];
                $n           = 0;
                foreach ($map['rows'] as $item) {
                    $model->rows[$n++] = null !== $item ? rows::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['totalCount'])) {
            $model->totalCount = $map['totalCount'];
        }

        return $model;
    }
}
