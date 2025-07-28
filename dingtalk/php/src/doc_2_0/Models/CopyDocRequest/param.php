<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CopyDocRequest;

use AlibabaCloud\Tea\Model;

class param extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example dentryUuid
     *
     * @var string
     */
    public $sourceDentryUuid;

    /**
     * @description This parameter is required.
     *
     * @example dentryUuid
     *
     * @var string
     */
    public $targetParentDentryUuid;

    /**
     * @example dentryUuid
     *
     * @var string
     */
    public $targetPreDentryUuid;
    protected $_name = [
        'sourceDentryUuid' => 'sourceDentryUuid',
        'targetParentDentryUuid' => 'targetParentDentryUuid',
        'targetPreDentryUuid' => 'targetPreDentryUuid',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->sourceDentryUuid) {
            $res['sourceDentryUuid'] = $this->sourceDentryUuid;
        }
        if (null !== $this->targetParentDentryUuid) {
            $res['targetParentDentryUuid'] = $this->targetParentDentryUuid;
        }
        if (null !== $this->targetPreDentryUuid) {
            $res['targetPreDentryUuid'] = $this->targetPreDentryUuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return param
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['sourceDentryUuid'])) {
            $model->sourceDentryUuid = $map['sourceDentryUuid'];
        }
        if (isset($map['targetParentDentryUuid'])) {
            $model->targetParentDentryUuid = $map['targetParentDentryUuid'];
        }
        if (isset($map['targetPreDentryUuid'])) {
            $model->targetPreDentryUuid = $map['targetPreDentryUuid'];
        }

        return $model;
    }
}
