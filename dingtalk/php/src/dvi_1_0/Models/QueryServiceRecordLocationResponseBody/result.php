<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryServiceRecordLocationResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryServiceRecordLocationResponseBody\result\locations;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var locations[]
     */
    public $locations;

    /**
     * @var string
     */
    public $recordId;
    protected $_name = [
        'locations' => 'locations',
        'recordId' => 'recordId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->locations) {
            $res['locations'] = [];
            if (null !== $this->locations && \is_array($this->locations)) {
                $n = 0;
                foreach ($this->locations as $item) {
                    $res['locations'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->recordId) {
            $res['recordId'] = $this->recordId;
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
        if (isset($map['locations'])) {
            if (!empty($map['locations'])) {
                $model->locations = [];
                $n = 0;
                foreach ($map['locations'] as $item) {
                    $model->locations[$n++] = null !== $item ? locations::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['recordId'])) {
            $model->recordId = $map['recordId'];
        }

        return $model;
    }
}
