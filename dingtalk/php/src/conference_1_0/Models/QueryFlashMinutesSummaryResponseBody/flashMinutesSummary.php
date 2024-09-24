<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryFlashMinutesSummaryResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryFlashMinutesSummaryResponseBody\flashMinutesSummary\summary;
use AlibabaCloud\Tea\Model;

class flashMinutesSummary extends Model
{
    /**
     * @var int
     */
    public $status;

    /**
     * @var summary[]
     */
    public $summary;
    protected $_name = [
        'status'  => 'status',
        'summary' => 'summary',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->summary) {
            $res['summary'] = [];
            if (null !== $this->summary && \is_array($this->summary)) {
                $n = 0;
                foreach ($this->summary as $item) {
                    $res['summary'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return flashMinutesSummary
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['summary'])) {
            if (!empty($map['summary'])) {
                $model->summary = [];
                $n              = 0;
                foreach ($map['summary'] as $item) {
                    $model->summary[$n++] = null !== $item ? summary::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
