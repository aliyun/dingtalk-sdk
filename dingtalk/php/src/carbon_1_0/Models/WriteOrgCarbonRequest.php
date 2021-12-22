<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcarbon_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcarbon_1_0\Models\WriteOrgCarbonRequest\orgDetailsList;
use AlibabaCloud\Tea\Model;

class WriteOrgCarbonRequest extends Model
{
    /**
     * @description 入参集
     *
     * @var orgDetailsList[]
     */
    public $orgDetailsList;
    protected $_name = [
        'orgDetailsList' => 'orgDetailsList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->orgDetailsList) {
            $res['orgDetailsList'] = [];
            if (null !== $this->orgDetailsList && \is_array($this->orgDetailsList)) {
                $n = 0;
                foreach ($this->orgDetailsList as $item) {
                    $res['orgDetailsList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return WriteOrgCarbonRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['orgDetailsList'])) {
            if (!empty($map['orgDetailsList'])) {
                $model->orgDetailsList = [];
                $n                     = 0;
                foreach ($map['orgDetailsList'] as $item) {
                    $model->orgDetailsList[$n++] = null !== $item ? orgDetailsList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
