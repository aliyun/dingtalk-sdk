<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainEmpPoolUserResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainEmpPoolUserResponseBody\content\empVos;
use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @var empVos[]
     */
    public $empVos;

    /**
     * @var int
     */
    public $maxResults;

    /**
     * @var int
     */
    public $nextToken;

    /**
     * @var int
     */
    public $totalCount;
    protected $_name = [
        'empVos' => 'empVos',
        'maxResults' => 'maxResults',
        'nextToken' => 'nextToken',
        'totalCount' => 'totalCount',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->empVos) {
            $res['empVos'] = [];
            if (null !== $this->empVos && \is_array($this->empVos)) {
                $n = 0;
                foreach ($this->empVos as $item) {
                    $res['empVos'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->totalCount) {
            $res['totalCount'] = $this->totalCount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['empVos'])) {
            if (!empty($map['empVos'])) {
                $model->empVos = [];
                $n = 0;
                foreach ($map['empVos'] as $item) {
                    $model->empVos[$n++] = null !== $item ? empVos::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['totalCount'])) {
            $model->totalCount = $map['totalCount'];
        }

        return $model;
    }
}
