<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetDentryRequest;

use AlibabaCloud\Tea\Model;

class option extends Model
{
    /**
     * @var string[]
     */
    public $appIdsForAppProperties;

    /**
     * @example true
     *
     * @var bool
     */
    public $withThumbnail;
    protected $_name = [
        'appIdsForAppProperties' => 'appIdsForAppProperties',
        'withThumbnail' => 'withThumbnail',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->appIdsForAppProperties) {
            $res['appIdsForAppProperties'] = $this->appIdsForAppProperties;
        }
        if (null !== $this->withThumbnail) {
            $res['withThumbnail'] = $this->withThumbnail;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return option
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appIdsForAppProperties'])) {
            if (!empty($map['appIdsForAppProperties'])) {
                $model->appIdsForAppProperties = $map['appIdsForAppProperties'];
            }
        }
        if (isset($map['withThumbnail'])) {
            $model->withThumbnail = $map['withThumbnail'];
        }

        return $model;
    }
}
