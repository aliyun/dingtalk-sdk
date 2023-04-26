<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models;

use AlibabaCloud\Tea\Model;

class ManagementListSpacesRequest extends Model
{
    /**
     * @var string[]
     */
    public $spaceIds;

    /**
     * @var string
     */
    public $unionId;
    protected $_name = [
        'spaceIds' => 'spaceIds',
        'unionId'  => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->spaceIds) {
            $res['spaceIds'] = $this->spaceIds;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ManagementListSpacesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['spaceIds'])) {
            if (!empty($map['spaceIds'])) {
                $model->spaceIds = $map['spaceIds'];
            }
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
