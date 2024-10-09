<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryTemplateInfoResponseBody;

use AlibabaCloud\Tea\Model;

class templateIntroduction extends Model
{
    /**
     * @var string
     */
    public $banner;

    /**
     * @var string
     */
    public $detail;

    /**
     * @var string
     */
    public $title;
    protected $_name = [
        'banner' => 'banner',
        'detail' => 'detail',
        'title'  => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->banner) {
            $res['banner'] = $this->banner;
        }
        if (null !== $this->detail) {
            $res['detail'] = $this->detail;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return templateIntroduction
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['banner'])) {
            $model->banner = $map['banner'];
        }
        if (isset($map['detail'])) {
            $model->detail = $map['detail'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
