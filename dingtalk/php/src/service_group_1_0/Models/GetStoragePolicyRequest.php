<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetStoragePolicyRequest extends Model
{
    /**
     * @example TICKET_IMAGE
     *
     * @var string
     */
    public $bizType;

    /**
     * @example wahah.txt
     *
     * @var string
     */
    public $fileName;

    /**
     * @example 10000
     *
     * @var int
     */
    public $fileSize;

    /**
     * @var string
     */
    public $openTeamId;
    protected $_name = [
        'bizType'    => 'bizType',
        'fileName'   => 'fileName',
        'fileSize'   => 'fileSize',
        'openTeamId' => 'openTeamId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->fileName) {
            $res['fileName'] = $this->fileName;
        }
        if (null !== $this->fileSize) {
            $res['fileSize'] = $this->fileSize;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetStoragePolicyRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['fileName'])) {
            $model->fileName = $map['fileName'];
        }
        if (isset($map['fileSize'])) {
            $model->fileSize = $map['fileSize'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }

        return $model;
    }
}
