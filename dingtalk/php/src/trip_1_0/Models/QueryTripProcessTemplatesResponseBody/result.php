<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\QueryTripProcessTemplatesResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\QueryTripProcessTemplatesResponseBody\result\schemas;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var schemas[]
     */
    public $schemas;
    protected $_name = [
        'schemas' => 'schemas',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->schemas) {
            $res['schemas'] = [];
            if (null !== $this->schemas && \is_array($this->schemas)) {
                $n = 0;
                foreach ($this->schemas as $item) {
                    $res['schemas'][$n++] = null !== $item ? $item->toMap() : $item;
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
        if (isset($map['schemas'])) {
            if (!empty($map['schemas'])) {
                $model->schemas = [];
                $n = 0;
                foreach ($map['schemas'] as $item) {
                    $model->schemas[$n++] = null !== $item ? schemas::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
