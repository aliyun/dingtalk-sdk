<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryOrgDiyTemplatesResponseBody\diyTemplates;
use AlibabaCloud\Tea\Model;

class QueryOrgDiyTemplatesResponseBody extends Model
{
    /**
     * @var diyTemplates[]
     */
    public $diyTemplates;

    /**
     * @var bool
     */
    public $hasNext;

    /**
     * @var string
     */
    public $nextToken;

    /**
     * @var int
     */
    public $total;
    protected $_name = [
        'diyTemplates' => 'diyTemplates',
        'hasNext' => 'hasNext',
        'nextToken' => 'nextToken',
        'total' => 'total',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->diyTemplates) {
            $res['diyTemplates'] = [];
            if (null !== $this->diyTemplates && \is_array($this->diyTemplates)) {
                $n = 0;
                foreach ($this->diyTemplates as $item) {
                    $res['diyTemplates'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->hasNext) {
            $res['hasNext'] = $this->hasNext;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->total) {
            $res['total'] = $this->total;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryOrgDiyTemplatesResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['diyTemplates'])) {
            if (!empty($map['diyTemplates'])) {
                $model->diyTemplates = [];
                $n = 0;
                foreach ($map['diyTemplates'] as $item) {
                    $model->diyTemplates[$n++] = null !== $item ? diyTemplates::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['hasNext'])) {
            $model->hasNext = $map['hasNext'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['total'])) {
            $model->total = $map['total'];
        }

        return $model;
    }
}
