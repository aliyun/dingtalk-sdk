<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ProvidePointResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var int
     */
    public $availableQuota;

    /**
     * @var int
     */
    public $provideNum;

    /**
     * @var bool
     */
    public $provideSuccess;
    protected $_name = [
        'availableQuota' => 'availableQuota',
        'provideNum' => 'provideNum',
        'provideSuccess' => 'provideSuccess',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->availableQuota) {
            $res['availableQuota'] = $this->availableQuota;
        }
        if (null !== $this->provideNum) {
            $res['provideNum'] = $this->provideNum;
        }
        if (null !== $this->provideSuccess) {
            $res['provideSuccess'] = $this->provideSuccess;
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
        if (isset($map['availableQuota'])) {
            $model->availableQuota = $map['availableQuota'];
        }
        if (isset($map['provideNum'])) {
            $model->provideNum = $map['provideNum'];
        }
        if (isset($map['provideSuccess'])) {
            $model->provideSuccess = $map['provideSuccess'];
        }

        return $model;
    }
}
