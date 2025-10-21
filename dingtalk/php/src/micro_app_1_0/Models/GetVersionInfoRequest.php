<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetVersionInfoRequest extends Model
{
    /**
     * @var string
     */
    public $unifiedAppId;

    /**
     * @var string
     */
    public $versionId;
    protected $_name = [
        'unifiedAppId' => 'unifiedAppId',
        'versionId' => 'versionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->unifiedAppId) {
            $res['unifiedAppId'] = $this->unifiedAppId;
        }
        if (null !== $this->versionId) {
            $res['versionId'] = $this->versionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetVersionInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['unifiedAppId'])) {
            $model->unifiedAppId = $map['unifiedAppId'];
        }
        if (isset($map['versionId'])) {
            $model->versionId = $map['versionId'];
        }

        return $model;
    }
}
