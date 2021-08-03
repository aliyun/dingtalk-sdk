<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\GetAttachsApprovalResponseBody\data;

use AlibabaCloud\Tea\Model;

class files extends Model
{
    /**
     * @var string
     */
    public $fileName;

    /**
     * @var string
     */
    public $originalFileUrl;

    /**
     * @var string
     */
    public $signFinishFileUrl;
    protected $_name = [
        'fileName'          => 'fileName',
        'originalFileUrl'   => 'originalFileUrl',
        'signFinishFileUrl' => 'signFinishFileUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fileName) {
            $res['fileName'] = $this->fileName;
        }
        if (null !== $this->originalFileUrl) {
            $res['originalFileUrl'] = $this->originalFileUrl;
        }
        if (null !== $this->signFinishFileUrl) {
            $res['signFinishFileUrl'] = $this->signFinishFileUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return files
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fileName'])) {
            $model->fileName = $map['fileName'];
        }
        if (isset($map['originalFileUrl'])) {
            $model->originalFileUrl = $map['originalFileUrl'];
        }
        if (isset($map['signFinishFileUrl'])) {
            $model->signFinishFileUrl = $map['signFinishFileUrl'];
        }

        return $model;
    }
}
