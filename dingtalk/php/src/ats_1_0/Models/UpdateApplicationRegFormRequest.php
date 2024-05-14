<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\UpdateApplicationRegFormRequest\dingPanFile;
use AlibabaCloud\Tea\Model;

class UpdateApplicationRegFormRequest extends Model
{
    /**
     * @example ddats
     *
     * @var string
     */
    public $bizCode;

    /**
     * @description This parameter is required.
     *
     * @example {"key":"value"}
     *
     * @var string
     */
    public $content;

    /**
     * @description This parameter is required.
     *
     * @var dingPanFile
     */
    public $dingPanFile;
    protected $_name = [
        'bizCode'     => 'bizCode',
        'content'     => 'content',
        'dingPanFile' => 'dingPanFile',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizCode) {
            $res['bizCode'] = $this->bizCode;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->dingPanFile) {
            $res['dingPanFile'] = null !== $this->dingPanFile ? $this->dingPanFile->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateApplicationRegFormRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizCode'])) {
            $model->bizCode = $map['bizCode'];
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['dingPanFile'])) {
            $model->dingPanFile = dingPanFile::fromMap($map['dingPanFile']);
        }

        return $model;
    }
}
