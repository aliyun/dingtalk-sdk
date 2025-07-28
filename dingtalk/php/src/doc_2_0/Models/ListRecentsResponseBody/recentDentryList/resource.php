<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListRecentsResponseBody\recentDentryList;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListRecentsResponseBody\recentDentryList\resource\spaceInfo;
use AlibabaCloud\Tea\Model;

class resource extends Model
{
    /**
     * @example dentryUuid
     *
     * @var string
     */
    public $dentryUuid;

    /**
     * @example driveDentryId
     *
     * @var string
     */
    public $driveDentryId;

    /**
     * @example driveSpaceId
     *
     * @var string
     */
    public $driveSpaceId;

    /**
     * @example docx
     *
     * @var string
     */
    public $extension;

    /**
     * @example name
     *
     * @var string
     */
    public $name;

    /**
     * @example spaceInfo
     *
     * @var spaceInfo
     */
    public $spaceInfo;

    /**
     * @example https://example.com
     *
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
     * @return resource
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
