<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ShareUrlRequest;

use AlibabaCloud\Tea\Model;

class param extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example dentryUuid
     *
     * @var string
     */
    public $dentryUuid;

    /**
     * @example true
     *
     * @var bool
     */
    public $triggerShare;
    protected $_name = [
        'dentryUuid'   => 'dentryUuid',
        'triggerShare' => 'triggerShare',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dentryUuid) {
            $res['dentryUuid'] = $this->dentryUuid;
        }
        if (null !== $this->triggerShare) {
            $res['triggerShare'] = $this->triggerShare;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return param
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dentryUuid'])) {
            $model->dentryUuid = $map['dentryUuid'];
        }
        if (isset($map['triggerShare'])) {
            $model->triggerShare = $map['triggerShare'];
        }

        return $model;
    }
}
