<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CreateShortcutResponseBody\openDentryInfo;

use AlibabaCloud\Tea\Model;

class spaceInfo extends Model
{
    /**
     * @example im
     *
     * @var string
     */
    public $sceneType;
    protected $_name = [
        'sceneType' => 'sceneType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->sceneType) {
            $res['sceneType'] = $this->sceneType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return spaceInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['sceneType'])) {
            $model->sceneType = $map['sceneType'];
        }

        return $model;
    }
}
