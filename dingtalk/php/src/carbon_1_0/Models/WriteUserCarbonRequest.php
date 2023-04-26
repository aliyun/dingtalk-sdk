<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcarbon_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcarbon_1_0\Models\WriteUserCarbonRequest\userDetailsList;
use AlibabaCloud\Tea\Model;

class WriteUserCarbonRequest extends Model
{
    /**
     * @var userDetailsList[]
     */
    public $userDetailsList;
    protected $_name = [
        'userDetailsList' => 'userDetailsList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->userDetailsList) {
            $res['userDetailsList'] = [];
            if (null !== $this->userDetailsList && \is_array($this->userDetailsList)) {
                $n = 0;
                foreach ($this->userDetailsList as $item) {
                    $res['userDetailsList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return WriteUserCarbonRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['userDetailsList'])) {
            if (!empty($map['userDetailsList'])) {
                $model->userDetailsList = [];
                $n                      = 0;
                foreach ($map['userDetailsList'] as $item) {
                    $model->userDetailsList[$n++] = null !== $item ? userDetailsList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
