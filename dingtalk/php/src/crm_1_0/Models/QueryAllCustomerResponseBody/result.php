<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryAllCustomerResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryAllCustomerResponseBody\result\values;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 100
     *
     * @var int
     */
    public $maxResults;

    /**
     * @example 100
     *
     * @var string
     */
    public $nextToken;

    /**
     * @var values[]
     */
    public $values;
    protected $_name = [
        'maxResults' => 'maxResults',
        'nextToken'  => 'nextToken',
        'values'     => 'values',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->values) {
            $res['values'] = [];
            if (null !== $this->values && \is_array($this->values)) {
                $n = 0;
                foreach ($this->values as $item) {
                    $res['values'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['values'])) {
            if (!empty($map['values'])) {
                $model->values = [];
                $n             = 0;
                foreach ($map['values'] as $item) {
                    $model->values[$n++] = null !== $item ? values::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
