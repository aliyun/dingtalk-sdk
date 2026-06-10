<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CopyDocWithAppAuthResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CopyDocWithAppAuthResponseBody\syncCopyResult\spaceInfo;
use AlibabaCloud\Tea\Model;

class syncCopyResult extends Model
{
    /**
     * @var string
     */
    public $dentryUuid;

    /**
     * @var string
     */
    public $driveDentryId;

    /**
     * @var string
     */
    public $driveSpaceId;

    /**
     * @var string
     */
    public $extension;

    /**
     * @var string
     */
    public $name;

    /**
     * @var spaceInfo
     */
    public $spaceInfo;

    /**
     * @var string
     */
    public $url;
    protected $_name = [
        'dentryUuid' => 'dentryUuid',
        'driveDentryId' => 'driveDentryId',
        'driveSpaceId' => 'driveSpaceId',
        'extension' => 'extension',
        'name' => 'name',
        'spaceInfo' => 'spaceInfo',
        'url' => 'url',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dentryUuid) {
            $res['dentryUuid'] = $this->dentryUuid;
        }
        if (null !== $this->driveDentryId) {
            $res['driveDentryId'] = $this->driveDentryId;
        }
        if (null !== $this->driveSpaceId) {
            $res['driveSpaceId'] = $this->driveSpaceId;
        }
        if (null !== $this->extension) {
            $res['extension'] = $this->extension;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->spaceInfo) {
            $res['spaceInfo'] = null !== $this->spaceInfo ? $this->spaceInfo->toMap() : null;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return syncCopyResult
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dentryUuid'])) {
            $model->dentryUuid = $map['dentryUuid'];
        }
        if (isset($map['driveDentryId'])) {
            $model->driveDentryId = $map['driveDentryId'];
        }
        if (isset($map['driveSpaceId'])) {
            $model->driveSpaceId = $map['driveSpaceId'];
        }
        if (isset($map['extension'])) {
            $model->extension = $map['extension'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['spaceInfo'])) {
            $model->spaceInfo = spaceInfo::fromMap($map['spaceInfo']);
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
