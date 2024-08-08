<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryScreenResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $operatePermission;

    /**
     * @var int
     */
    public $screenId;

    /**
     * @var string
     */
    public $screenName;

    /**
     * @var string
     */
    public $state;

    /**
     * @var string
     */
    public $thumbUrl;
    protected $_name = [
        'operatePermission' => 'operatePermission',
        'screenId'          => 'screenId',
        'screenName'        => 'screenName',
        'state'             => 'state',
        'thumbUrl'          => 'thumbUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->operatePermission) {
            $res['operatePermission'] = $this->operatePermission;
        }
        if (null !== $this->screenId) {
            $res['screenId'] = $this->screenId;
        }
        if (null !== $this->screenName) {
            $res['screenName'] = $this->screenName;
        }
        if (null !== $this->state) {
            $res['state'] = $this->state;
        }
        if (null !== $this->thumbUrl) {
            $res['thumbUrl'] = $this->thumbUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operatePermission'])) {
            $model->operatePermission = $map['operatePermission'];
        }
        if (isset($map['screenId'])) {
            $model->screenId = $map['screenId'];
        }
        if (isset($map['screenName'])) {
            $model->screenName = $map['screenName'];
        }
        if (isset($map['state'])) {
            $model->state = $map['state'];
        }
        if (isset($map['thumbUrl'])) {
            $model->thumbUrl = $map['thumbUrl'];
        }

        return $model;
    }
}
