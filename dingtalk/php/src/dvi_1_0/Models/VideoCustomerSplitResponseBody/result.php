<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\VideoCustomerSplitResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\VideoCustomerSplitResponseBody\result\createServiceRecordResult;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var createServiceRecordResult[]
     */
    public $createServiceRecordResult;
    protected $_name = [
        'createServiceRecordResult' => 'createServiceRecordResult',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->createServiceRecordResult) {
            $res['createServiceRecordResult'] = [];
            if (null !== $this->createServiceRecordResult && \is_array($this->createServiceRecordResult)) {
                $n = 0;
                foreach ($this->createServiceRecordResult as $item) {
                    $res['createServiceRecordResult'][$n++] = null !== $item ? $item->toMap() : $item;
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
        if (isset($map['createServiceRecordResult'])) {
            if (!empty($map['createServiceRecordResult'])) {
                $model->createServiceRecordResult = [];
                $n = 0;
                foreach ($map['createServiceRecordResult'] as $item) {
                    $model->createServiceRecordResult[$n++] = null !== $item ? createServiceRecordResult::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
