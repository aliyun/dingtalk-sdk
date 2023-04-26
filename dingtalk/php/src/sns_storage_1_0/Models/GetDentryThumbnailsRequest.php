<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetDentryThumbnailsRequest extends Model
{
    /**
     * @var string[]
     */
    public $dentryIds;

    /**
     * @example union_id
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'dentryIds' => 'dentryIds',
        'unionId'   => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dentryIds) {
            $res['dentryIds'] = $this->dentryIds;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetDentryThumbnailsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dentryIds'])) {
            if (!empty($map['dentryIds'])) {
                $model->dentryIds = $map['dentryIds'];
            }
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
