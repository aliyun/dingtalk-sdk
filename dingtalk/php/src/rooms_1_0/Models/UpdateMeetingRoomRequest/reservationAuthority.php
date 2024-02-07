<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\UpdateMeetingRoomRequest;

use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\UpdateMeetingRoomRequest\reservationAuthority\authorizedMembers;
use AlibabaCloud\Tea\Model;

class reservationAuthority extends Model
{
    /**
     * @var authorizedMembers[]
     */
    public $authorizedMembers;
    protected $_name = [
        'authorizedMembers' => 'authorizedMembers',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->authorizedMembers) {
            $res['authorizedMembers'] = [];
            if (null !== $this->authorizedMembers && \is_array($this->authorizedMembers)) {
                $n = 0;
                foreach ($this->authorizedMembers as $item) {
                    $res['authorizedMembers'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return reservationAuthority
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['authorizedMembers'])) {
            if (!empty($map['authorizedMembers'])) {
                $model->authorizedMembers = [];
                $n                        = 0;
                foreach ($map['authorizedMembers'] as $item) {
                    $model->authorizedMembers[$n++] = null !== $item ? authorizedMembers::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
